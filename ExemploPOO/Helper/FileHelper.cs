using System;


namespace ExemploPOO.Helper
{
  public class FileHelper
  {
    public void ListarDiretorios(string caminho)
    {
      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

      foreach (var retorno in retornoCaminho)
      {
        System.Console.WriteLine(retorno);
      }
    }


    public void ListarArquivosDiretorios(string caminho)
    {
      var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

      foreach (var retorno in retornoArquivos)
      {
        System.Console.WriteLine(retorno);
      }
    }


    //---Criar Diretorios ----------------------------------------------------------------
    public void CriarDiretorio(string caminho)
    {
      var retorno = Directory.CreateDirectory(caminho);
      System.Console.WriteLine(retorno.FullName);
    }


    //----Apagar Diretório----------------------------------------------------
    public void ApagarDiretorio(string caminho, bool apagarArquivos)
    {
      Directory.Delete(caminho, apagarArquivos);
    }

    //---Criar Arquivo de texto----------------------------------------------------
    public void CriarArquivoTexto(string caminho, string conteudo)
    {
      if (!File.Exists(caminho))
      {
        File.WriteAllText(caminho, conteudo);
      }


    }

    //---Criar Arquivo de texto Estream----------------------------------------------------
    public void CriarArquivotextoStream(string caminho, List<string> conteudo)
    {

      using (var stream = File.CreateText(caminho))
      {

        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

    //----Adicionar novas linhas em um Arquivo----------------------------------------------------
    public void Adicionartexto(string caminho, string conteudo)
    {
      File.AppendAllText(caminho, conteudo);
    }

    public void AdicionarTextoStream(string caminho, List<string> conteudo)
    {
      using (var stream = File.AppendText(caminho))
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }

      }
    }


    //---Lendo Arquivos---------
    public void LerArquivos(string caminho)
    {
      var conteudo = File.ReadAllLines(caminho);

      foreach (var linha in conteudo)
      {
        System.Console.WriteLine(linha);
      }
    }

    public void LerArquivoStream(string caminho)
    {
      string linha = string.Empty;

      using (var stream = File.OpenText(caminho))
      {
        while ((linha = stream.ReadLine()) != null)
        {
          System.Console.WriteLine(linha);
        }
      }
    }

    //---- Movendo Arquivo ------------------------
    public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
    {
      File.Move(caminho, novoCaminho, sobrescrever);
    }

    //---Copiar Arquivo ------------------------
    public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
    {
      File.Copy(caminho, novoCaminho, sobrescrever);

    }

    //----Deletar Arquivo ------------------------
    public void DeletarArquivo(string caminho)
    {
      File.Delete(caminho);
    }
  }
}