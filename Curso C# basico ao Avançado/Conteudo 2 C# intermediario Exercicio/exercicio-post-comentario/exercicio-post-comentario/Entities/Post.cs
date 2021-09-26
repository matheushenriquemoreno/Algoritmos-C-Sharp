using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_post_comentario.Entities
{
    class Post
    {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Coment> Comments { get; set; } = new List<Coment>(); // estanciando lista


        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComent(Coment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Coment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // e responsavel por fazer a montagem de uma string da forma que eu montar
            sb.AppendLine(Title); // adiciona texto ate o final e coloca uma quebra de linha
            sb.Append(Likes); // adicionar um texto no inicio ou apos a quebra de linha
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss "));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Coment co in Comments)
            {
                sb.AppendLine(co.Text);
            }
            return sb.ToString(); // retorna o texto comforme montado a cima 
        }


    }
}
