namespace BDDistribuida
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //fragmentos de código para cargar localidades, tablas, campos, etc. en los controles correspondientes
        List<Fragmento> fragmentos = new List<Fragmento>()
        {
            new Fragmento(
                "Alumno",
                "Alumno1a",
                new List<string>{"NoCtrl","Nom","Ap","Am","Dom","Tel"},
                "Lic",
                "Vertical",
                "NoCtrl"
            ),
            new Fragmento(
                "Alumno",
                "Alumno1b",
                new List<string>{"NoCtrl","Cvecarr","Sem","Prom","Titulo"},
                "Lic",
                "Vertical",
                "NoCtrl"
            ),
            new Fragmento(
                "Alumno",
                "Alumno2a",
                new List<string>{"NoCtrl","Nom","Ap","Am","Dom","Tel"},
                "Ing",
                "Vertical",
                "NoCtrl"
            ),

            new Fragmento(
                "Alumno",
                "Alumno2b",
                new List<string>{"NoCtrl","Cvecarr","Sem","Prom","Titulo"},
                "Ing",
                "Vertical",
                "NoCtrl"
            ),
          new Fragmento(
              "Carrera",
            "Carrera",
            new List<string>{"Cvecarr","Nomcarr","Añocarr"},
            "",
            "Horizontal",
            "Cvecarr"
          ),
            new Fragmento(
                "Materia",
                "Materia",
                new List<string>{"Cvmat","Nommat","Creditos"},
                "",
                "Horizontal",
                "Cvmat"
            ),
            new Fragmento(
                "Maestro",
                "Maestro",
                new List<string>{"Cvemaestro","Nommaestro","Apmaestro","Ammaestro","Grado"},
                "",
                "Horizontal",
                "Cvemaestro"
            ),

            new Fragmento(
                "Califica",
                "Califica",
                new List<string>{"NoCtrl","Cvemat","Cvemaestro","Calificacion","Oportunidad"},
                "",
                "Horizontal",
                "NoCtrl"
                )
        };

        //catalogo 
        List<Catalogo> catalogo = new List<Catalogo>()
        {
                new Catalogo(1, "Alumno1a","L1", "Primario"),
                new Catalogo(2, "Alumno1b","L2", "Primario"),
                new Catalogo(3,"Alumno2a","L3", "Primario"),
                new Catalogo(4,"Alumno2b","L5", "Primario"),
                new Catalogo(5,"Carrera","L2", "Primario"),
                new Catalogo(6,"Materia","L7", "Primario"),
                new Catalogo(7,"Maestro","L3", "Primario"),
                new Catalogo(8,"Maestro","L4", "Replica"),
                new Catalogo(9,"Alumno1a","L6", "Replica"),
                new Catalogo(10, "Alumno1b","L9", "Replica")
        };

        //crear distancias
        Dictionary<string, Dictionary<string, int>> distancias = new Dictionary<string, Dictionary<string, int>>()
        {
            { "L1", new Dictionary<string, int>{{"L1",0},{"L2",1},{"L3",2},{"L4",2},{"L5",1},{"L6",2},{"L7",3},{"L8",2},{"L9",3}} },
            { "L2", new Dictionary<string, int>{{"L1",1},{"L2",0},{"L3",1},{"L4",2},{"L5",2},{"L6",1},{"L7",2},{"L8",3},{"L9",2}} },
            { "L3", new Dictionary<string, int>{{"L1",2},{"L2",1},{"L3",0},{"L4",1},{"L5",2},{"L6",2},{"L7",1},{"L8",2},{"L9",3}} },
            { "L4", new Dictionary<string, int>{{"L1",2},{"L2",2},{"L3",1},{"L4",0},{"L5",1},{"L6",3},{"L7",2},{"L8",1},{"L9",2}} },
            { "L5", new Dictionary<string, int>{{"L1",1},{"L2",2},{"L3",2},{"L4",1},{"L5",0},{"L6",2},{"L7",3},{"L8",2},{"L9",1}} },
            { "L6", new Dictionary<string, int>{{"L1",2},{"L2",1},{"L3",2},{"L4",3},{"L5",2},{"L6",0},{"L7",1},{"L8",2},{"L9",3}} },
            { "L7", new Dictionary<string, int>{{"L1",3},{"L2",2},{"L3",1},{"L4",2},{"L5",3},{"L6",1},{"L7",0},{"L8",1},{"L9",2}} },
            { "L8", new Dictionary<string, int>{{"L1",2},{"L2",3},{"L3",2},{"L4",1},{"L5",2},{"L6",2},{"L7",1},{"L8",0},{"L9",1}} },
            { "L9", new Dictionary<string, int>{{"L1",3},{"L2",2},{"L3",3},{"L4",2},{"L5",1},{"L6",3},{"L7",2},{"L8",1},{"L9",0}} }
        };
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            var selected = cmbLocalidad.SelectedItem;

            if (selected == null)
            {
                MessageBox.Show("Seleccione una localidad");
                return;
            }

            string localidadActual = selected.ToString()!;

            //tablas y campos
            var tablasSeleccionadas = chkTablas.CheckedItems.Cast<string>().ToList();
            if (tablasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una tabla");
                return;
            }

            var camposSeleccionados = chkCampos.CheckedItems.Cast<string>().ToList();
            if (camposSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un campo");
                return;
            }

            string campoCondicion = cmbCampoCondicion.SelectedItem?.ToString() ?? "";

            string operador = cmbOperador.SelectedItem?.ToString() ?? "";
            string valor = txtValor.Text;
            //saber si el usaruio quiere usar condición 
            bool usarCondicion =
                !string.IsNullOrEmpty(campoCondicion) &&
                !string.IsNullOrEmpty(operador) &&
                !string.IsNullOrEmpty(valor);
            //validar que haya seleccionado al menos una tabla y un campo
            if (usarCondicion)
            {
                if (operador != "=" &&
                    operador != "<" &&
                    operador != ">" &&
                    operador != "<=" &&
                    operador != ">=" &&
                    operador != "<>")
                {
                    MessageBox.Show("Operador no soportado");
                    return;
                }
            }
            //localidad actual
            if (cmbLocalidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una localidad");
                return;
            }

            if (!distancias.ContainsKey(localidadActual))
            {
                MessageBox.Show("Localidad no definida en distancias");
                return;
            }



            //buscar fragmentos por campos 
            var fragmentosNecesarios = new List<Fragmento>();

            foreach (var campo in camposSeleccionados)
            {
                var encontrados = fragmentos
                    .Where(f =>
                        f.Campos.Contains(campo) &&
                        tablasSeleccionadas.Contains(f.TablaOriginal)
                    )
                    .ToList();

                fragmentosNecesarios.AddRange(encontrados);
            }

            if (usarCondicion)
            {
                var encontradosCondicion = fragmentos
                    .Where(f =>
                        f.Campos.Contains(campoCondicion) &&
                        tablasSeleccionadas.Contains(f.TablaOriginal)
                    )
                    .ToList();

                fragmentosNecesarios.AddRange(encontradosCondicion);
            }

            //quitar duplicados de la lista de fragmentos necesarios
            fragmentosNecesarios = fragmentosNecesarios
                .GroupBy(f => f.Nombre)
                .Select(g => g.First())
                .ToList();
            // Aplicar condición
            if (campoCondicion == "Titulo")
            {
                if (valor == "Ing" || valor == "Lic")
                {
                    fragmentosNecesarios = fragmentosNecesarios
                        .Where(f => f.Condicion == valor)
                        .ToList();
                }
            }



            //  Filtrar localidades activas
            var localidadesActivas = chkLocalidades.CheckedItems.Cast<string>().ToList();

            var catalogoActivo = catalogo
                .Where(c => localidadesActivas.Contains(c.Nodo))
                .ToList();

            //  Obtener resultado
            var resultadoFinal = new List<Catalogo>();

            foreach (var frag in fragmentosNecesarios)
            {
                var opciones = catalogoActivo
                    .Where(c => c.FragmentoNombre == frag.Nombre)
                    .ToList();

                if (opciones.Count == 0) 
                {
                    txtResultado.Clear();
                    txtResultado.Text = "No se puede realizar la consulta";
                    return;

                }

                var mejor = opciones
                    .OrderBy(c => distancias[localidadActual][c.Nodo])
                    .First();

                resultadoFinal.Add(mejor);
            }

            //  Mostrar resultado
            txtResultado.Clear();

            if (resultadoFinal.Count == 0)
            {
                txtResultado.Text = "No se puede realizar la consulta";
                return;
            }

            txtResultado.AppendText("Sí se puede realizar la consulta\n\n");
            txtResultado.AppendText("Localidad\tTabla\n");

            foreach (var r in resultadoFinal)
            {
                txtResultado.AppendText($"{r.Nodo}\t{r.FragmentoNombre}\n");
            }


        }

        private void chkCampos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void chkTablas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            chkCampos.Items.Clear();

            // Obtener tablas seleccionadas
            var tablas = chkTablas.CheckedItems.Cast<string>().ToList();


            string tablaActual = chkTablas.Items[e.Index].ToString() ?? "";
            if (e.NewValue == CheckState.Checked)
            {
                tablas.Add(tablaActual);
            }
            else
            {
                tablas.Remove(tablaActual);
            }

            // Agregar campos según tablas
            foreach (var tabla in tablas)
            {
                if (tabla == "Alumno")
                {
                    chkCampos.Items.Add("NoCtrl");
                    if (!chkCampos.Items.Contains("Titulo"))
                    {
                        chkCampos.Items.Add("Titulo");
                    }

                    if (!cmbCampoCondicion.Items.Contains("Titulo"))
                    {
                        cmbCampoCondicion.Items.Add("Titulo");
                    }
                    if (!chkCampos.Items.Contains("Nom"))
                    {
                        chkCampos.Items.Add("Nom");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Nom"))
                    {
                        cmbCampoCondicion.Items.Add("Nom");
                    }
                    if (!chkCampos.Items.Contains("Ap"))
                    {
                        chkCampos.Items.Add("Ap");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Ap"))
                    {
                        cmbCampoCondicion.Items.Add("Ap");
                    }
                    if (!chkCampos.Items.Contains("Am"))
                    {
                        chkCampos.Items.Add("Am");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Am"))
                    {
                        cmbCampoCondicion.Items.Add("Am");
                    }
                    if (!chkCampos.Items.Contains("Dom"))
                    {
                        chkCampos.Items.Add("Dom");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Dom"))
                    {
                        cmbCampoCondicion.Items.Add("Dom");
                    }
                    if (!chkCampos.Items.Contains("Tel"))
                    {
                        chkCampos.Items.Add("Tel");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Tel"))
                    {
                        cmbCampoCondicion.Items.Add("Tel");
                    }
                    if (!chkCampos.Items.Contains("Cvecarr"))
                    {
                        chkCampos.Items.Add("Cvecarr");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Cvecarr"))
                    {
                        cmbCampoCondicion.Items.Add("Cvecarr");
                    }
                    if (!chkCampos.Items.Contains("Sem"))
                    {
                        chkCampos.Items.Add("Sem");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Sem"))
                    {
                        cmbCampoCondicion.Items.Add("Sem");
                    }
                    if (!chkCampos.Items.Contains("Prom"))
                    {
                        chkCampos.Items.Add("Prom");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Prom"))
                    {
                        cmbCampoCondicion.Items.Add("Prom");
                    }
                    if (!chkCampos.Items.Contains("Titulo"))
                    {
                        chkCampos.Items.Add("Titulo");
                    }
                    if (!cmbCampoCondicion.Items.Contains("Titulo"))
                    {
                        cmbCampoCondicion.Items.Add("Titulo");
                    }


                }

                if (tabla == "Carrera")
                {
                    chkCampos.Items.Add("Nomcarr");
                }

                if (tabla == "Materia")
                {
                    chkCampos.Items.Add("Nommat");
                    chkCampos.Items.Add("Creditos");
                }

                if (tabla == "Maestro")
                {
                    chkCampos.Items.Add("Nommaestro");
                    chkCampos.Items.Add("Apmaestro");
                    chkCampos.Items.Add("Ammaestro");
                    chkCampos.Items.Add("Grado");
                }
            }
        }

        private void chkTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkCampos.Items.Clear();
            cmbCampoCondicion.Items.Clear();
        }

        private void picGrafo_Click(object sender, EventArgs e)
        {

        }

        private void cmbCampoCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gráfo f = new Gráfo();
            f.Show();
        }
    }
}
