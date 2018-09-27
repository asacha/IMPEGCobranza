package com.freelance.ascstb.cobranza.adapter

import android.support.v7.widget.RecyclerView
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import com.freelance.ascstb.cobranza.R
import com.freelance.ascstb.cobranza.model.entity.Factura

class RVInvoiceAdapter(private var invoiceList: MutableList<Factura>, private val listener: (Factura) -> Unit) : RecyclerView.Adapter<RVInvoiceAdapter.ViewHolder>() {
    override fun onCreateViewHolder(parent: ViewGroup, position: Int): ViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.invoice_list_item, parent, false)
        return ViewHolder(view)
    }

    override fun getItemCount(): Int {
        return invoiceList.size
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val invoice = invoiceList.get(position)

        holder.tvDate.text = invoice.fechaEmision
        holder.tvCompany.text = invoice.empresa
        holder.tvTPI.text = invoice.rfc
        holder.tvAmount.text = "$ " + invoice.total.toString()

        holder.bind(invoice, listener)
    }

    fun updateInvoiceList(invoiceList: List<Factura>) {
        Log.d(TAG, "updateInvoiceList: ")
        this.invoiceList.clear()
        this.invoiceList.addAll(invoiceList)

        notifyDataSetChanged()
    }

    inner class ViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val tvDate = itemView.findViewById<TextView>(R.id.tvDate)
        val tvCompany = itemView.findViewById<TextView>(R.id.tvCompany)
        val tvTPI = itemView.findViewById<TextView>(R.id.tvTPI)
        val tvAmount = itemView.findViewById<TextView>(R.id.tvAmount)

        fun bind(invoice: Factura, clickListener: (Factura) -> Unit) {
            itemView.setOnClickListener { clickListener(invoice) }
        }
    }

    companion object {
        private val TAG = RVInvoiceAdapter::class.java.simpleName + "_TAG"
    }
}