# Programas e exemplos utilizando C# e WPF (V�deos)
Dentro deste projeto eu criei uma pasta chamada component com outra pasta dentro chamada Videos "./component/Videos" 
O que n�o pode ficar �bvio � que para fazer o projeto rodar o v�deo corretamente neste endereco � que eu copio essa estrutura para
onde est�o os bin�rios ou seja para dentro da pasta 'WpfMediaPlayerVideo\bin\Debug' ou '\WpfMediaPlayerVideo\bin\Release'
o caminho total no meu computador seria esse 'C:\Users\Developer\Source\Repos\c-sharp-wpf\Curso\WpfMediaPlayerVideo\WpfMediaPlayerVideo\bin\Release' ou 'C:\Users\Developer\Source\Repos\c-sharp-wpf\Curso\WpfMediaPlayerVideo\WpfMediaPlayerVideo\bin\Debug'
Foi a forma mas simples que encontrei de fazer o V�deo rodar no meu projeto de exemplo sem fazer muitas "mirabolan�as" claro que se seu arquivo estiver em uma url "http://wwww.seusite.com/Wildfire.wmv" isso pouco vai importar para voc� pois seu endere�o � uma url
que est� em um servidor qualquer mas se voc� precisa fazer testes locais essa forma que fiz pode ser interessante de se testar pois funciona quase como um endere�o relativo o aplicativo vai ler os v�deo aonde o bin�rio(compila��o) estive que no caso
do Visual Studio � a pasta Release ou Debug.
<MediaElement Source="./component/Videos/Wildlife.wmv"  LoadedBehavior="Manual" Name="mePlayer" />