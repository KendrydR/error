using System;
using System.Collections.Generic;

namespace WebApplication1.Widgets.MiWidgetPersonalizado.Models
{
    public class WidgetDataModel
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<ItemWidget> Items { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}