 private void button1_Click(object sender, EventArgs e)
        {
//BOTON LISTA ENLAZADA
            sInformacion sData = new sInformacion();
            sData.iCodigo = int.Parse(textBox1.Text);
            sData.sMarca = textBox2.Text;

            cInventario.pInserta(sData);

            textBox1.Text = ""; 
            textBox1.Focus();


            textBox2.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Crear Pila
            int m = int.Parse(txtmaximo.Text);
            objeto = new pilas(m);
            MessageBox.Show("Pila Creada");

        }

        private void btnpush_Click(object sender, EventArgs e)
        {

            //Push
            int n;
            n = int.Parse(txtnumero.Text);
            objeto.push(n);
            txtnumero.Text = "";
            txtnumero.Focus();
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            //Pop
            int n;
            n = objeto.pop();
            MessageBox.Show("salio " + n);
        }

        private void btncrear2_Click(object sender, EventArgs e)
        {
            //Generar Cola
            int n;
            n = int.Parse(txtmaximo2.Text);
            x = new Colas(n);
            MessageBox.Show("Se Creo La Cola");
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            //Agregar a Cola
            int n;
            n = int.Parse(txtnumero2.Text);
            x.agregar_cola(n);
           
            txtnumero2.Clear();
            txtnumero2.Focus();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Sacar de la cola
            int n;
            n = x.del_cola();
            if (n == -666)
            {
                MessageBox.Show("Sin Valor ");
                    
            }
            else
            {
                MessageBox.Show("Salio " + n);
            }
        }