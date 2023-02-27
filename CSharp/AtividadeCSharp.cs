/* 07a - SP2 - Atividade 1 - Desenvolvimento de sistema de controle de clientes */

using System;
using System.Collections.Generic;
using System.IO;

class Cliente
{
    private string nome;
    private int id;
    private bool pagaImpostos;

    public Cliente(string nome, int id, bool pagaImpostos)
    {
        this.nome = nome;
        this.id = id;
        this.pagaImpostos = pagaImpostos;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int ID
    {
        get { return id; }
    }

    public bool PagaImpostos
    {
        get { return pagaImpostos; }
        set { pagaImpostos = value; }
    }

    public virtual string TipoCliente()
    {
        return "Cliente";
    }

    public override string ToString()
    {
        return "Nome: " + nome + ", ID: " + id + ", Paga Impostos: " + pagaImpostos;
    }
}

class PessoaFisica : Cliente
{
    private string cpf;
    private DateTime dataNascimento;

    public PessoaFisica(string nome, int id, bool pagaImpostos, string cpf, DateTime dataNascimento) 
        : base(nome, id, pagaImpostos)
    {
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
    }

    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public DateTime DataNascimento
    {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    public override string TipoCliente()
    {
        return "Pessoa Física";
    }

    public override string ToString()
    {
        return base.ToString() + ", CPF: " + cpf + ", Data de Nascimento: " + dataNascimento.ToShortDateString();
    }
}

class PessoaJuridica : Cliente
{
    private string cnpj;

    public PessoaJuridica(string nome, int id, bool pagaImpostos, string cnpj) 
        : base(nome, id, pagaImpostos)
    {
        this.cnpj = cnpj;
    }

    public string CNPJ
    {
        get { return cnpj; }
        set { cnpj = value; }
    }

    public override string TipoCliente()
    {
        return "Pessoa Jurídica";
    }

    public override string ToString()
    {
        return base.ToString() + ", CNPJ: " + cnpj;
    }
}

class ClienteManager
{
    private List<Cliente> clientes;
    private string arquivo;

    public ClienteManager(string arquivo)
    {
        this.arquivo = arquivo;
        clientes = new List<Cliente>();
    }

    public void CadastrarCliente(Cliente c)
    {
        clientes.Add