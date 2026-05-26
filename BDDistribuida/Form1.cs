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


        private Dictionary<string, List<string>> estructuraLogica = new Dictionary<string, List<string>>
        {
            { "Alumno", new List<string> { "Alumno1a", "Alumno1b", "Alumno2a", "Alumno2b" } },
            { "Carrera", new List<string> { "Carrera" } },
            { "Materia", new List<string> { "Materia" } },
            { "Maestro", new List<string> { "Maestro" } },
            { "Califica", new List<string> { "Califica" } }
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
            // 1. Validaciones iniciales
            if (cmbLocalidad.SelectedItem == null) { MessageBox.Show("Seleccione una localidad"); return; }
            string localidadActual = cmbLocalidad.SelectedItem.ToString()!;

            var tablasSeleccionadas = chkTablas.CheckedItems.Cast<string>().ToList();
            var camposSeleccionados = chkCampos.CheckedItems.Cast<string>().ToList();

            if (tablasSeleccionadas.Count == 0 || camposSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione tablas y campos");
                return;
            }

            // 2. Preparación de condiciones
            string campoCondicion = cmbCampoCondicion.SelectedItem?.ToString() ?? "";
            string valor = txtValor.Text;
            bool usarCondicion = !string.IsNullOrEmpty(campoCondicion) && !string.IsNullOrEmpty(valor);

            // 3. Motor de Consulta (Transparencia de Fragmentación)
            var fragmentosNecesarios = new List<Fragmento>();
            foreach (var tabla in tablasSeleccionadas)
            {
                // Traemos todos los fragmentos físicos asociados a la tabla lógica
                var fragsDeEstaTabla = fragmentos.Where(f => f.TablaOriginal == tabla).ToList();

                // Aplicamos el motor de inferencia: descartamos fragmentos incompatibles con la condición
                if (usarCondicion)
                {
                    fragsDeEstaTabla = fragsDeEstaTabla.Where(f =>
                        string.IsNullOrEmpty(f.Condicion) || f.Condicion == valor
                    ).ToList();
                }
                fragmentosNecesarios.AddRange(fragsDeEstaTabla);
            }
            fragmentosNecesarios = fragmentosNecesarios.GroupBy(f => f.Nombre).Select(g => g.First()).ToList();

            // 4. Filtrar disponibilidad según localidades marcadas
            var localidadesActivas = chkLocalidades.CheckedItems.Cast<string>().ToList();
            var catalogoActivo = catalogo.Where(c => localidadesActivas.Contains(c.Nodo)).ToList();

            // 5. Validación de integridad: ¿Tenemos todos los fragmentos necesarios?
            var nombresRequeridos = fragmentosNecesarios.Select(f => f.Nombre).ToList();
            if (!nombresRequeridos.All(n => catalogoActivo.Any(c => c.FragmentoNombre == n)))
            {
                txtResultado.Text = "Consulta fallida: Algunos fragmentos no están disponibles en las localidades activas.";
                return;
            }

            // 6. Algoritmo de Sintonía (Optimización por costo total)
            var mejorNodo = localidadesActivas.OrderBy(nodo => {
                int costoTotal = 0;
                foreach (var frag in fragmentosNecesarios)
                {
                    var ubicaciones = catalogoActivo.Where(c => c.FragmentoNombre == frag.Nombre);
                    costoTotal += ubicaciones.Min(u => distancias[localidadActual][u.Nodo]);
                }
                return costoTotal;
            }).First();

            // 7. Generar resultado final
            var resultadoFinal = new List<Catalogo>();
            foreach (var frag in fragmentosNecesarios)
            {
                var mejorUbicacion = catalogoActivo.Where(c => c.FragmentoNombre == frag.Nombre)
                                                   .OrderBy(c => distancias[localidadActual][c.Nodo])
                                                   .First();
                resultadoFinal.Add(mejorUbicacion);
            }

            // 8. Visualización y Grafo
            txtResultado.Clear();
            txtResultado.AppendText("Sí se puede realizar la consulta\n\nLocalidad\tTabla\n");
            foreach (var r in resultadoFinal)
            {
                txtResultado.AppendText($"{r.Nodo}\t\t{r.FragmentoNombre}\n");
            }

            // Integración con el Grafo
            List<string> nodosGanadores = resultadoFinal.Select(r => r.Nodo).Distinct().ToList();
            Gráfo f = new Gráfo();
            f.ResaltarNodos(nodosGanadores);
            f.Show();



        }

        private void chkCampos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void chkTablas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Usamos BeginInvoke para asegurar que la UI se actualice después 
            // de que el estado del CheckBox haya cambiado realmente.
            this.BeginInvoke(new Action(() => {

                // 1. Limpiamos las listas de campos
                chkCampos.Items.Clear();
                cmbCampoCondicion.Items.Clear();

                // 2. Usamos un HashSet para recolectar campos únicos sin esfuerzo
                // El HashSet evita automáticamente que se agreguen duplicados.
                var listaCamposUnicos = new HashSet<string>();

                // 3. Iteramos solo sobre las tablas que quedaron MARCADAS
                foreach (var tabla in chkTablas.CheckedItems)
                {
                    string nombreTabla = tabla.ToString();

                    // Buscamos los fragmentos de esa tabla lógica
                    // Esto asume que tienes una lista global llamada 'fragmentos'
                    var frags = fragmentos.Where(f => f.TablaOriginal == nombreTabla).ToList();

                    foreach (var f in frags)
                    {
                        foreach (var campo in f.Campos)
                        {
                            listaCamposUnicos.Add(campo);
                        }
                    }
                }

                // 4. Llenamos los controles con los campos únicos encontrados
                foreach (var campo in listaCamposUnicos)
                {
                    chkCampos.Items.Add(campo);
                    cmbCampoCondicion.Items.Add(campo);
                }
            }));

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
