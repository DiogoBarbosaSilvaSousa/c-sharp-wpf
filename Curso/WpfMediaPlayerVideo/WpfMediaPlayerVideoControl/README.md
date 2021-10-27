# Programas e exemplos utilizando C# e WPF (Vídeos)
### Aviso importante
Dentro deste projeto eu criei uma pasta chamada component com outra pasta dentro chamada Videos "./component/Videos" 
O que não pode ficar óbvio é que para fazer o projeto rodar o vídeo corretamente neste endereco é que eu copio essa estrutura para
onde estão os binários ou seja para dentro da pasta 'WpfMediaPlayerVideoControl\bin\Debug' ou '\WpfMediaPlayerVideoControl\bin\Release'
o caminho total no meu computador seria esse 'C:\Users\Developer\Source\Repos\c-sharp-wpf\Curso\WpfMediaPlayerVideo\WpfMediaPlayerVideoControl\bin\Release' ou 'C:\Users\Developer\Source\Repos\c-sharp-wpf\Curso\WpfMediaPlayerVideo\WpfMediaPlayerVideoControl\bin\Debug'
Foi a forma mas simples que encontrei de fazer o Vídeo rodar no meu projeto de exemplo sem fazer muitas "mirabolanças" claro que se seu arquivo estiver em uma url "http://wwww.seusite.com/Wildfire.wmv" isso pouco vai importar para você pois seu endereço é uma url
que está em um servidor qualquer mas se você precisa fazer testes locais essa forma que fiz pode ser interessante de se testar pois funciona quase como um endereço relativo o aplicativo vai ler os vídeo aonde o binário(compilação) estive que no caso
do Visual Studio é a pasta Release ou Debug.
<MediaElement Source="./component/Videos/Wildlife.wmv"  LoadedBehavior="Manual" Name="mePlayer" />