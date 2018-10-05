package com.freelance.ascstb.cobranza.model.data.remote

import com.freelance.ascstb.cobranza.model.entity.InvoiceResponse
import com.freelance.ascstb.cobranza.model.entity.LoginResponse
import io.reactivex.Observable
import retrofit2.http.GET
import retrofit2.http.Query

interface RemoteService {
    @GET("dev/IMPEG/Cobranza/api/Usuario/API/Usuario/Autenticar")
    fun loginAttempt(@Query("NumeroCliente") clientNumber: String, @Query("Contrasena") password: String): Observable<LoginResponse>

    @GET("dev/IMPEG/Cobranza/api/Cobranza/API/Factura/obtenerFacturas")
    fun getInvoices(@Query("Token") token: String, @Query("NumeroCliente") clientNumber: String): Observable<InvoiceResponse>
}