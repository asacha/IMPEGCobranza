package com.freelance.ascstb.model.entity

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

    override fun toString(): String {
        return "LoginResponse: { error: $error, errorId: $errorId, mensajeError: $mensajeError, token: $token }"
    }
}