using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App02
{
    public class SeletorTemplate : DataTemplateSelector
    {
        DataTemplate ItemPessoaObrigatoria;
        DataTemplate ItemPessoaNObrigatoria;

        public SeletorTemplate()
        {
            ItemPessoaObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaObrigatoriaViewCell));
            ItemPessoaNObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaNObrigatoriaViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            MainPage.Pessoa pessoa = item as MainPage.Pessoa;
            if (pessoa.IsObrigatorio)
            {
                return ItemPessoaObrigatoria;
            }
            else
            {
                return ItemPessoaNObrigatoria;
            }
        }
    }
}
