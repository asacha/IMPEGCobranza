package com.freelance.ascstb.cobranza.viewmodel

import android.app.Application
import android.arch.lifecycle.AndroidViewModel
import android.arch.lifecycle.LiveData
import android.util.Log
import com.freelance.ascstb.cobranza.model.data.DataRepository
import com.freelance.ascstb.cobranza.model.data.local.LocalDataSource
import com.freelance.ascstb.cobranza.model.data.remote.RemoteDataSource
import com.freelance.ascstb.cobranza.model.entity.InvoiceResponse

class InvoiceViewModel(application: Application) : AndroidViewModel(application) {
    private val dataRepository = DataRepository(RemoteDataSource(), LocalDataSource(application))
    private var token = ""
    private var clientNumber = ""

    val invoiceList: LiveData<InvoiceResponse>
        get() {
            Log.d(TAG, "get login view model")
            return dataRepository.getInvoices(token, clientNumber)
        }

    fun setClientNumber(clientNumber: String) {
        Log.d(TAG, "setClientNumber: $clientNumber")
        this.clientNumber = clientNumber
    }

    fun setToken(token: String) {
        Log.d(TAG, "setPassword: $token")
        this.token = token
    }

    companion object {
        private val TAG = InvoiceViewModel::class.java.simpleName + "_TAG"
    }
}