Console.Clear();

// Criando um array
var myArray = new int[3];


// Lembre-se de sempre tratar seus erros dos mais especificos para os mais genericos.
// Sempre usar tambem varios blocos de try catch ao inves de um so para o codigo inteiro.

try // Tente
{
    // Forcando o estouro no array
    // for (var index = 0; index < 10; index++) // Exception gerada: System.IndexOutOfRangeException
    // {
    //     Console.WriteLine(myArray[index]);
    // }

    Save("");
}
catch(IndexOutOfRangeException ex) // Pegando exceptions especificas
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o item na lista");
}
catch(ArgumentNullException ex) // Pegando exceptions especificas
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Falha ao cadastrar o texto");
}
catch(MyException ex) // Pegando exceptions especificas
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.QuandoAconteceu);
    Console.WriteLine("Falha ao cadastrar o texto");
}
catch(Exception ex) // Pegando exceptions genericas
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado!");
}
finally // Finalmente. Sempre vai ser executado
{
    // Em caso de leitura de arquivo, sempre verificar se o arquivo esta aberto e fecha ele 
    // aqui no finally
    Console.WriteLine("Chegou ao fim");
}


// Disparando exceptions
static void Save(string text)
{
    if(string.IsNullOrEmpty(text))
        throw new MyException(DateTime.Now);
        // throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        // throw new Exception("O texto não pode ser nulo ou vazio");
}

public class MyException : Exception // Herdando de Exception
{
    public MyException(DateTime date) // Metodo construtor
    {
        QuandoAconteceu = date;
    }
    public DateTime QuandoAconteceu { get; set; }
}