package com.freelance.ascstb.cobranza.view

import android.content.Intent
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.TextView
import com.freelance.ascstb.cobranza.R
import com.freelance.ascstb.cobranza.model.entity.Factura
import com.freelance.ascstb.cobranza.utils.Keys

class InvoiceDetailActivity : AppCompatActivity() {
    lateinit var invoice: Factura

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_invoice_detail)

        loadInvoiceInfo()
    }

    private fun loadInvoiceInfo() {
        invoice = intent.getParcelableExtra(Keys.INVOICE)

        findViewById<TextView>(R.id.tvInvoiceNumber).text = invoice.numero
        findViewById<TextView>(R.id.tvInvoiceCompany).text = invoice.empresa
        findViewById<TextView>(R.id.tvInvoiceTPI).text = invoice.rfc
        findViewById<TextView>(R.id.tvInvoiceDate).text = invoice.fechaEmision
        findViewById<TextView>(R.id.tvInvoiceAmount).text = invoice.total.toString()
    }

    fun onPaymentConfirmationClicked(view: View) {
        Log.d(TAG, "onPaymentConfirmationClicked: ")
        val intent = Intent(applicationContext, PaymentActivity::class.java)
        intent.putExtra(Keys.INVOICE, invoice)
        startActivity(intent)
    }

    fun onViewLogClicked(view: View) {
        Log.d(TAG, "onViewLogClicked: ")
        val intent = Intent(applicationContext, InvoiceLogActivity::class.java)
        intent.putExtra(Keys.INVOICE, invoice)
        startActivity(intent)
    }

    companion object {
        private val TAG = InvoiceDetailActivity::class.java.simpleName + "_TAG"
    }
}
