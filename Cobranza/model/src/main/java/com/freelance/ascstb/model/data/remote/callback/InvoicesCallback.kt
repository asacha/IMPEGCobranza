package com.freelance.ascstb.model.data.remote.callback

import com.freelance.ascstb.model.entity.InvoiceResponse

interface InvoicesCallback {
    fun onError(error: String)

    fun onGetInvoicesResponse(invoices: InvoiceResponse)
}