using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace sistemaQuchooch.Data.QuchoochModels;

public partial class CarreraDto
{
    public int CodigoCarrera { get; set; }

    public int? CodigoNivelAcademico { get; set; }
    public string? NivelAcademico { get; set; }

    public string NombreCarrera { get; set; } = null!;

    public string? Estatus { get; set; }


}