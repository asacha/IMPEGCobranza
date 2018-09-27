package com.freelance.ascstb.cobranza.view

import android.arch.lifecycle.Observer
import android.arch.lifecycle.ViewModelProviders
import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.support.v7.widget.LinearLayoutManager
import android.support.v7.widget.RecyclerView
import android.util.Log
import com.freelance.ascstb.cobranza.R
import com.freelance.ascstb.cobranza.adapter.RVInvoiceAdapter
import com.freelance.ascstb.cobranza.model.entity.Factura
import com.freelance.ascstb.cobranza.viewmodel.InvoiceViewModel

class InvoiceActivity : AppCompatActivity() {
    private lateinit var token: String
    private lateinit var clientNumber: String
    private lateinit var viewModel: InvoiceViewModel
    private lateinit var adapter: RVInvoiceAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_invoice)

        Log.d(TAG, "onCreate: ")
        token = intent.getStringExtra("TOKEN")
        clientNumber = intent.getStringExtra("CLIENT_NUMBER")

        initRecyclerView()
        this.viewModel = ViewModelProviders.of(this).get(InvoiceViewModel::class.java)
        viewModel.setToken(token)
        viewModel.setClientNumber(clientNumber)
        viewModel.invoiceList.observe(this, Observer { invoiceResponse ->
            Log.d(TAG, "invoiceList.observe: $invoiceResponse")
            adapter.updateInvoiceList(invoiceResponse!!.facturas!!)
        })
    }

    private fun initRecyclerView() {
        Log.d(TAG, "initRecyclerView: ")
        val rvInvoiceList = findViewById<RecyclerView>(R.id.rvInvoice)
        val layoutManager = LinearLayoutManager(applicationContext)
        this.adapter = RVInvoiceAdapter(ArrayList<Factura>()){invoice: Factura -> invoiceClicked(invoice)}
        rvInvoiceList.layoutManager = layoutManager
        rvInvoiceList.adapter = adapter
    }

    private fun invoiceClicked(invoice: Factura) {
        Log.d(TAG, "invoiceClicked: $invoice")
    }

    companion object {
        private val TAG = InvoiceActivity::class.java.simpleName + "_TAG"
    }
}
