using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.InterfacesHerancaMultipla
{
    public class Mundo
    {
        public void ReceberAnimal(IAnimal animal)
        {
            animal.Respirar();
        }
        public void ReceberProgramador(IProgramador programador)
        {
            programador.Programar();
        }
        public void ReceberJogador(IEsportista esportista)
        {
            esportista.Competir();
        }
        public void CriarPessoas()
        {
            //JogadorFutebol jogadorFut = new JogadorFutebol();
            //CSharpMan cSharpMan1 = new CSharpMan();
            ////IAnimal animalNaoDarCerto = new IAnimal();//não é possivel instanciar um animal
            //IAnimal animalNaoDarCerto = new JogadorFutebol();//isso é possivel
            //animalNaoDarCerto.Respirar();//mas so tera acesso as metodos dispoveis na interface
            //ReceberAnimal(jogadorFut);
            //ReceberAnimal(cSharpMan1);
            ////ReceberJogador(cSharpMan1);//isso dara um erro de complição pois o CSharpMan não é um programador
            //ReceberProgramador(cSharpMan1);
            ////ReceberJogador(cSharpMan1);//isso dara um erro de complição pois o programador não é um CSharpMan
            //ReceberJogador(jogadorFut);
        }

    }
}
