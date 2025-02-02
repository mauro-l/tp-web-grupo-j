﻿using domino;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPromo
{
    public partial class Premios : System.Web.UI.Page
    {
        public string user { get; set; }
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["code"] != null ? Session["code"].ToString() : null;

            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.Listar();
            RepeaterArt.DataSource = ListaArticulo;
            RepeaterArt.DataBind();

        }
    }
}