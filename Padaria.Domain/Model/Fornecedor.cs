namespace Padaria.Domain.Model

{
    public class Fornecedor : IEntity
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstatual { get; set; }
        public string Site { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public void Adicionar(int id, string razaoSocial, string inscricaoEstatual, string cnpj, string site, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            InscricaoEstatual = inscricaoEstatual;
            Site = site;
            Telefone = telefone;
            Email = email;
        }

        public void Change(string razaoSocial, string site, string telefone, string email)
        {
            RazaoSocial = string.IsNullOrEmpty(razaoSocial) ? RazaoSocial : razaoSocial;

            Site = string.IsNullOrEmpty(site) ? Site : site;

            Telefone = string.IsNullOrEmpty(telefone) ? Telefone : telefone;

            Email = string.IsNullOrEmpty(email) ? Email : email;
        }
    }
}
