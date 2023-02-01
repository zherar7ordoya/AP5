// Métodos

    public void Alta(ref Cliente QueObjeto = null/* TODO Change to default(_) if this is not a reference type */)
    {
        var withBlock = this.Cliente;

        withBlock.Id = int.Parse(Vgui.Controls.Find("Id", false).First.Text);
        withBlock.Nombre = Vgui.Controls.Find("Nombre", false).First.Text;
        withBlock.FechaAlta = DateTime.Parse(Vgui.Controls.Find("FechaAlta", false).First.Text);
        withBlock.Activo = IIf(Vgui.Controls.Find("Activo", false).First.ToString.Last == "1", true, false);
        withBlock.Telefonos.Clear();

        while (Interaction.IIf(Interaction.MsgBox("¿Desea ingresar un teléfono?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes, true, false))

            withBlock.Telefonos.Add(new Telefono(null, Interaction.InputBox("Ingrese el número de teléfono")));

        // Le envía un mensaje a Lógica 
        this.ClienteD.Alta(this.Cliente);
    }