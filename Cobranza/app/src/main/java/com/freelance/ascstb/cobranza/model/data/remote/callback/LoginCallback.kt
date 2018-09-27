package com.freelance.ascstb.cobranza.model.data.remote.callback

import com.freelance.ascstb.cobranza.model.entity.LoginResponse

interface LoginCallback {
    fun onError(error: String)

    fun onLoginResponse(loginResponse: LoginResponse)
}