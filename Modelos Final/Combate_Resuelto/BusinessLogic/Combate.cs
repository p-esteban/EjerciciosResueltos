using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Environment;

namespace BusinessLogic
{
    public sealed class Combate
    {
        IJugador atacado;
        IJugador atacante;
        static Random random;

        public event Action<IJugador, IJugador> RondaIniciada;
        public event Action<IJugador> CombateFinalizado;

        static Combate()
        {
            random = new Random();
        }
        public Combate(IJugador jugador1, IJugador jugador2)
        {
          
            atacante = SeleccionarJugadorAleatoriamente(jugador1,jugador2);
            atacado = atacante.Equals(jugador1) ? jugador2 : jugador1; 
        }
        private void Combatir()
        {
            IJugador ganador;
            do
            {
                IniciarRonda();
                ganador  = EvaluarGanador();
            } while ( ganador is null);
            if (CombateFinalizado is not null)
            {
                CombateFinalizado.Invoke(ganador);
            }

            ResultadoCombate resultado = new ResultadoCombate(ganador.ToString(), atacado.ToString(), DateTime.Now);

            string json = JsonSerializer.Serialize(resultado);
            new Logger(GetFolderPath(SpecialFolder.Desktop) + $"\\ResultadosCombate.json").GuardarLog(json);


        }
        private IJugador EvaluarGanador()
        {
            if (atacado.PuntosDeVida == 0)
            {
                return atacante;
            }else
            {
                IJugador aux = atacante;
                atacante = atacado;
                atacado = aux;
                return null;
            }
        }
        public Task IniciarCombate()
        {
            return Task.Run(Combatir);
        }
        private void IniciarRonda()
        {
            if (RondaIniciada is not null)
            {
                RondaIniciada.Invoke(atacante, atacado);
                atacado.RecibirAtaque( atacante.Atacar());
            }
        }
        private IJugador SeleccionarJugadorAleatoriamente(IJugador jugador1, IJugador jugador2)
        {
            if (random.TirarUnaMoneda() == LadosMoneda.Cara)
            {
                return jugador1;
            }
            else
            {
                return jugador2;
            }
        }
        private IJugador SeleccionarPrimerAtacante(IJugador jugador1, IJugador jugador2)
        {
            if (jugador1.Nivel > jugador2.Nivel)
            {
                return jugador2;
            }else if(jugador1.Nivel < jugador2.Nivel)
            {
                return jugador1;
            }
            else
            {
                return SeleccionarJugadorAleatoriamente(jugador1 , jugador2);
            }
        }

    }
}
