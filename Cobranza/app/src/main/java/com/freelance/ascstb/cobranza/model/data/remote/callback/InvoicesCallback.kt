package com.freelance.ascstb.cobranza.model.data.remote.callback

import com.freelance.ascstb.cobranza.model.entity.InvoiceResponse

interface InvoicesCallback {
    fun onError(error: String)

    fun onGetInvoicesResponse(invoices: InvoiceResponse)
}