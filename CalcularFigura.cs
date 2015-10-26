using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class CalcularFigura
    {
        //Os atributos são privados, pois só vão ser utilizado dentro desta classe para aprensentar os resultados.
        private double _perimetro;
        private double _area;
        private double _calc;
        private double _valor1;
        private double _valor2;
        private double _altura;
        //Propriedade: pois necessita de fazer a verificação para o usuário não digitar
        //outro valor a não ser o esperado. Evitar número negativo por exemplo.
        public double Valor1
        {
            get
            {
                return this._valor1;
            }
            set
            {
                this._valor1 = value > 0 ? value : 0;
            }
        }

        //Propriedade (Verificação)
        public double Valor2
        {
            get
            {
                return this._valor2;
            }
            set
            {
                this._valor2 = value > 0 ? value : 0;
            }
        }

        //Propriedade (Verificação)
        public double Altura
        {
            get
            {
                return this._altura;
            }
            set
            {
                this._altura = value > 0 ? value : 0;
            }
        }


        //Método que faz o calculo do Perimetro e Área do Triângulo de acordo com os valores que o usuário informar.
        public void Triangulo()
        {
            Console.WriteLine("Sua escolha foi o TRIÂNCULO \n");
            Console.WriteLine("Digite um valor para seu lado: ");
            Valor1 = double.Parse(Console.ReadLine());

            _perimetro = Valor1 * 3;
            _area = (Math.Sqrt(3) / 4) * Math.Pow(Valor1, 2);

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Quadrado de acordo com os valores que o usuário informar.
        public void Quadrado()
        {
            Console.WriteLine("Sua escolha foi o QUADRADO \n");
            Console.WriteLine("Digite um valor para seu lado: ");
            Valor1 = double.Parse(Console.ReadLine());

            _perimetro = Valor1 * 4;
            _area = Valor1 * Valor1;

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Retangulo de acordo com os valores que o usuário informar.
        public void Retangulo()
        {
            Console.WriteLine("Sua escolha foi o RETÂNGULO \n");
            Console.WriteLine("Digite um valor para o lado 1: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para o lado 2: ");
            Valor2 = double.Parse(Console.ReadLine());

            _perimetro = (Valor1 * 2) + (Valor2 * 2);
            _area = Valor1 * Valor2;

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Circulo de acordo com os valores que o usuário informar.
        public void Circulo()
        {
            Console.WriteLine("Sua escolha foi o CIRCULO \n");
            Console.WriteLine("Digite um valor para o tamanho do circulo: ");
            Valor1 = double.Parse(Console.ReadLine());

            _perimetro = 2 * Math.PI * Valor1;
            _area = Math.PI * Math.Pow(Valor1, 2);

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Losango de acordo com os valores que o usuário informar.
        public void Losango()
        {
            Console.WriteLine("Sua escolha foi o LOSANGO \n");
            Console.WriteLine("Digite um valor para o lado: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para diagonal menor: ");
            Valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para diagonal maior: ");
            _calc = double.Parse(Console.ReadLine());

            _perimetro = Valor1 * 4;
            _area = (_calc * Valor2) / 2;

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Paralelogramo de acordo com os valores que o usuário informar.
        public void Paralelogramo()
        {
            Console.WriteLine("Sua escolha foi o PARALELOGRAMO \n");
            Console.WriteLine("Digite um valor para a base: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para altura: ");
            Valor2 = double.Parse(Console.ReadLine());

            _perimetro = (Valor2 * 2) + (Valor1 * 2);
            _area = Valor2 * Valor1;

            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }


        //Método que faz o calculo do Perimetro e Área do Trapezio de acordo com os valores que o usuário informar.
        public void Trapezio()
        {
            Console.WriteLine("Sua escolha foi o TRAPÉZIO \n");
            Console.WriteLine("Digite um valor para a base maior: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a base menor: ");
            Valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para altura: ");
            Altura = double.Parse(Console.ReadLine());

            _area = Altura * (Valor1 * Valor2) / 2;

            _calc = Math.Sqrt((Altura * 2 + Altura * 2));
            _perimetro = Valor2 + Valor1 + _calc * 2;


            Console.WriteLine("PERÍMETRO: {0}cm", _perimetro);
            Console.WriteLine("ÁREA: {0}cm²", _area);
            Console.ReadKey();
        }
    }
}
