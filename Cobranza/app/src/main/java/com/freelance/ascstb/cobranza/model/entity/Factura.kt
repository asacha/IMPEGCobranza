package com.freelance.ascstb.cobranza.model.entity

import com.google.gson.annotations.Expose
import com.google.gson.annotations.SerializedName

class Factura {
    @SerializedName("Empresa")
    @Expose
    var empresa: String? = null
    @SerializedName("RFC")
    @Expose
    var rfc: String? = null
    @SerializedName("Total")
    @Expose
    var total: Double? = null
    @SerializedName("FechaEmision")
    @Expose
    var fechaEmision: String? = null

    override fun toString(): String {
        return "Factura: { empresa: $empresa, rfc: $rfc, total: $total, fechaEmision: $fechaEmision }"
    }
}