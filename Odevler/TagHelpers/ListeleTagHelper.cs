using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevler.TagHelpers
{
    [HtmlTargetElement("dizi")]
    public class ListeleTagHelper : TagHelper
    {
        public List<string> ogeler { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "listele";
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<ul class='list-group'>");
            string format = "<li class='list-group-item'></li>";
            foreach (var item in ogeler)
            {

                stringBuilder.AppendFormat(format,item);
            }
            stringBuilder.Append("</ul>");
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context,output);
        }
    }
}
