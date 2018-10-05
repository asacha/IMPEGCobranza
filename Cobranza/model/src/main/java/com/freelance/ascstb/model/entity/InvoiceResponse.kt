package com.freelance.ascstb.model.entity

import com.google.gson.annotations.Expose
import com.google.gson.annotations.SerializedName

class InvoiceResponse {

    @SerializedName("Error")
    @Expose
    var error: Boolean? = null
    @SerializedName("ErrorId")
    @Expose
    var errorId: Int? = null
    @SerializedName("MensajeError")
    @Expose
    var mensajeError: String? = null
    @SerializedName("Facturas")
    @Expose
    var facturas: List<Factura>? = null

    override fun toString(): String {
        return "InvoiceResponse: { error: $error, errorId: $errorId, mensajeError: $mensajeError, facturas: ${facturas!!.size}"
    }
}