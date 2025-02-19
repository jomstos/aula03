namespace aula_03;

class Televisao
{
    //o metodo construtor possui o mesmo nome da classe, ele não possui retorno(nem mesmo o void), este metodo é executa sempre que uma instancia da classe é criada.
    //por padrão , o C# cria um método construtor publico vazio, mas podemos criar métodos construtores com outras visibilidades e recebendo paramentros, se necessario.

    public Televisao(float tamanho)
    {
        if (tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MAXIMO)
        {
            //uma exceção interrompe o fluxo normal do sistema.
            throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) não é suportado.");
        }
        Tamanho = tamanho;
        Volume = 10;
    }
    // Optamos pela utilização da constante para tornar o código mais legível.
    private const float TAMANHO_MINIMO = 20;
    private const float TAMANHO_MAXIMO = 90;

    private int VOLUME_MAXIMO = 100;

    private int VOLUME_MINIMO = 0;

    private int VOLUME_PADRAO = 10;



    //Get = permite que seja executado a leitura do valor atual da propriedade
    //seet = permite que seja atribuido um valor para a propriedade
    //classes e propriedades e metodos possuem modificadores de acesso
    // public: visiveis a todo projeto
    //internal: visiveis somente no namespace
    //protected: visiveis somente na classe e nas classes que herdam
    //private: visiveis somente na calsse que foram criados
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < VOLUME_MAXIMO)
        {
            Volume++;
        }
        else
        {
            Console.WriteLine("A TV já está no vulume máximo permitido");
        }
    }
    public void DiminuirVolume()
    {
        if (Volume > VOLUME_MINIMO)
        {
            Volume--;
        }
        else 
        {
            Console.WriteLine("A TV já está no vulume minimo permitido");

        }
    }
    
}