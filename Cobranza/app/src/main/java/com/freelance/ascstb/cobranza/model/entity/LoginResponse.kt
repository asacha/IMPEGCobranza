package com.freelance.ascstb.cobranza.model.entity

import com.google.gson.annotations.Expose
import com.google.gson.annotations.SerializedName

class LoginResponse {

    @SerializedName("Error")
    @Expose
    var error: Boolean? = null
    @SerializedName("ErrorId")
    @Expose
    var errorId: Int? = null
    @SerializedName("MensajeError")
    @Expose
    var mensajeError: String? = null
    @SerializedName("Token")
    @Expose
    var token: String? = null
    @SerializedName("UsuarioExiste")
    @Expose
    var usuarioExiste: Boolean? = null
    @SerializedName("ContrasenaCorrecta")
    @Expose
    var contrasenaCorrecta: Boolean? = null
    @SerializedName("Baja")
    @Expose
    var baja: Boolean? = null

}
