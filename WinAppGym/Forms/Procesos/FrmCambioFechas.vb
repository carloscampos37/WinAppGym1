Private Sub GrabaMembresia(ByRef vfecha1 As DateTime, ByRef vfecha2 As DateTime)
    Using bd As Model1 = New Model1()
        Dim user = (From dd In bd.Zk_MembresiasxSocio Where dd.ID = (vMembId) Select dd).FirstOrDefault()
        vfecha1 = Convert.ToDateTime(DtpInicio.Text)
        vfecha2 = Convert.ToDateTime(DtpTermino.Text)
        user.FechaInicio = vfecha1
        user.FechaFinal = vfecha2
        user.Referencia = TxtReferencia.Text
        user.FechaModificacion = DateTime.Now.Date
        user.AutorizacionesID = Convert.ToInt32(ctr_AyuAutorizacion.Codigo)
        bd.SaveChanges()
    End Using
End Sub