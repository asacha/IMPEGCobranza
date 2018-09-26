package com.freelance.ascstb.cobranza.model.data.remote

import android.util.Log
import com.freelance.ascstb.cobranza.model.entity.LoginResponse
import io.reactivex.Observable
import retrofit2.Retrofit
import retrofit2.adapter.rxjava2.RxJava2CallAdapterFactory
import retrofit2.converter.gson.GsonConverterFactory

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

    fun loginAttempt(clientNumber: String, password: String) {
        Log.d(TAG, "loginAttempt: clientNumer: $clientNumber. password: $password")
    }
    //endregion

    companion object {
        private val TAG = RemoteDataSource::class.java.simpleName + "_TAG"
        private const val BASE_URL = "http://132.148.140.31/"
    }
}