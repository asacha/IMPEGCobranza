package com.freelance.ascstb.model.data

import android.arch.lifecycle.LiveData
import android.arch.lifecycle.MutableLiveData
import android.util.Log
import com.freelance.ascstb.model.data.local.LocalDataSource
import com.freelance.ascstb.model.data.remote.RemoteDataSource
import com.freelance.ascstb.model.data.remote.callback.InvoicesCallback
import com.freelance.ascstb.model.data.remote.callback.LoginCallback
import com.freelance.ascstb.model.entity.InvoiceResponse
import com.freelance.ascstb.model.entity.LoginResponse

class DataRepository(private var remoteDataSource: RemoteDataSource, private var localDataSource: LocalDataSource) {
    var loginData = MutableLiveData<LoginResponse>()
    var invoicesData = MutableLiveData<InvoiceResponse>()

    fun loginAttempt(clientNumber:String, password: String): LiveData<LoginResponse> {
        remoteDataSource.loginAttempt(clientNumber, password, object: LoginCallback {
            override fun onError(error: String) {
                Log.d(TAG, "onError: clientNumer: $clientNumber. password: $password")
            }

            override fun onLoginResponse(loginResponse: LoginResponse) {
                Log.d(TAG, "onLoginResponse: clientNumer: $clientNumber. password: $password")
                loginData.value = loginResponse
            }
        })

        return loginData
    }

    fun getInvoices(token: String, clientNumber: String) : LiveData<InvoiceResponse> {
        remoteDataSource.getInvoices(token, clientNumber, object: InvoicesCallback {
            override fun onError(error: String) {
                Log.d(TAG, "onError: token: $token, clientNumber: $clientNumber")
            }

            override fun onGetInvoicesResponse(invoices: InvoiceResponse) {
                Log.d(TAG, "onGetInvoicesResponse: token: $token, clientNumber: $clientNumber")
                invoicesData.value = invoices
            }
        })

        return invoicesData
    }

    companion object {
        private val TAG = DataRepository::class.java.simpleName + "_TAG"
    }
}