package com.freelance.ascstb.model.data.remote.callback

import com.freelance.ascstb.model.entity.LoginResponse

interface LoginCallback {
    fun onError(error: String)

    fun onLoginResponse(loginResponse: LoginResponse)
}