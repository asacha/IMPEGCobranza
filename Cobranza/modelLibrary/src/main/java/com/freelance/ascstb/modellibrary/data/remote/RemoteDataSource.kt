package com.freelance.ascstb.cobranza.model.data.remote

import android.util.Log
import com.freelance.ascstb.cobranza.model.data.remote.callback.InvoicesCallback
import com.freelance.ascstb.cobranza.model.data.remote.callback.LoginCallback
import com.freelance.ascstb.cobranza.model.entity.InvoiceResponse
import com.freelance.ascstb.cobranza.model.entity.LoginResponse
import io.reactivex.Observable
import io.reactivex.Observer
import io.reactivex.android.schedulers.AndroidSchedulers
import io.reactivex.disposables.Disposable
import io.reactivex.schedulers.Schedulers
import retrofit2.Retrofit
import retrofit2.adapter.rxjava2.RxJava2CallAdapterFactory
import retrofit2.converter.gson.GsonConverterFactory
import sun.rmi.runtime.Log

class RemoteDataSource {
    private fun createInstance(): Retrofit {
        Log.d(TAG, "createInstance: ")

        return Retrofit.Builder()
                .baseUrl(BASE_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .addCallAdapterFactory(RxJava2CallAdapterFactory.create())
                .build()
    }

    //region Login
    private fun loginAttemptServer(clientNumber: String, password: String): Observable<LoginResponse> {
        return createInstance().create(RemoteService::class.java).loginAttempt(clientNumber, password)
    }

    fun loginAttempt(clientNumber: String, password: String, callback: LoginCallback) {
        Log.d(TAG, "loginAttempt: clientNumer: $clientNumber. password: $password")
        loginAttemptServer(clientNumber, password)
                .subscribeOn(Schedulers.io())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribe(object : Observer<LoginResponse> {
                    override fun onComplete() {
                        Log.d(TAG, "onComplete: ")
                    }

                    override fun onSubscribe(d: Disposable) {
                        Log.d(TAG, "onSubscribe: ")
                    }

                    override fun onNext(response: LoginResponse) {
                        Log.d(TAG, "onNext: $response")
                        callback.onLoginResponse(response)
                    }

                    override fun onError(e: Throwable) {
                        println(e.stackTrace)
                        callback.onError(e.message!!.toString())
                    }
                })
    }
    //endregion

    //region Invoices
    private fun getInvoicesServer(token: String, clientNumber: String): Observable<InvoiceResponse> {
        return createInstance().create(RemoteService::class.java).getInvoices(token, clientNumber)
    }

    fun getInvoices(token: String, clientNumber: String, callback: InvoicesCallback) {
        getInvoicesServer(token, clientNumber)
                .subscribeOn(Schedulers.io())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribe(object : Observer<InvoiceResponse> {
                    override fun onComplete() {
                        Log.d(TAG, "onComplete: ")
                    }

                    override fun onSubscribe(d: Disposable) {
                        Log.d(TAG, "onSubscribe: ")
                    }

                    override fun onNext(response: InvoiceResponse) {
                        Log.d(TAG, "onNext: $response")
                        callback.onGetInvoicesResponse(response)
                    }

                    override fun onError(e: Throwable) {
                        Log.d(TAG, "onError: ${e.message!!}")
                        callback.onError(e.message!!.toString())
                    }
                })
    }
    //endregion

    companion object {
        private val TAG = RemoteDataSource::class.java.simpleName + "_TAG"
        private const val BASE_URL = "http://132.148.140.31/"
    }
}