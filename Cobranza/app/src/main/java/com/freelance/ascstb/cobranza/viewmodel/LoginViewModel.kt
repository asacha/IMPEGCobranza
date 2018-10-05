package com.freelance.ascstb.cobranza.viewmodel

import android.app.Application
import android.arch.lifecycle.AndroidViewModel
import android.arch.lifecycle.LiveData
import android.util.Log
import com.freelance.ascstb.model.data.DataRepository
import com.freelance.ascstb.model.data.local.LocalDataSource
import com.freelance.ascstb.model.data.remote.RemoteDataSource
import com.freelance.ascstb.model.entity.LoginResponse

class LoginViewModel(application: Application) : AndroidViewModel(application) {
    private val dataRepository = DataRepository(RemoteDataSource(), LocalDataSource(application))
    private var clientNumber = ""
    private var password = ""

    val login: LiveData<LoginResponse>
        get() {
            Log.d(TAG, "get login view model")
            return dataRepository.loginAttempt(clientNumber, password)
        }

    fun setClientNumber(clientNumber: String) {
        Log.d(TAG, "setClientNumber: $clientNumber")
        this.clientNumber = clientNumber
    }

    fun setPassword(password: String) {
        Log.d(TAG, "setPassword: $password")
        this.password = password
    }

    companion object {
        private val TAG = LoginViewModel::class.java.simpleName + "_TAG"
    }
}