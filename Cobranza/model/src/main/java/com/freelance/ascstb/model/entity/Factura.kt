package com.freelance.ascstb.model.entity

import android.os.Parcel
import android.os.Parcelable

import com.google.gson.annotations.Expose
import com.google.gson.annotations.SerializedName

class Factura protected constructor(`in`: Parcel) : Parcelable {

    @SerializedName("Numero")
    @Expose
    var numero: String? = null
    @SerializedName("Empresa")
    @Expose
    var empresa: String? = null
    @SerializedName("RFC")
    @Expose
    var rfc: String? = null
    @SerializedName("Total")
    @Expose
    var total: Double? = null
    @SerializedName("FechaEmision")
    @Expose
    var fechaEmision: String? = null

    init {
        numero = `in`.readString()
        empresa = `in`.readString()
        rfc = `in`.readString()
        if (`in`.readByte().toInt() == 0) {
            total = null
        } else {
            total = `in`.readDouble()
        }
        fechaEmision = `in`.readString()
    }

    override fun describeContents(): Int {
        return 0
    }

    override fun writeToParcel(parcel: Parcel, i: Int) {

        parcel.writeString(numero)
        parcel.writeString(empresa)
        parcel.writeString(rfc)
        if (total == null) {
            parcel.writeByte(0.toByte())
        } else {
            parcel.writeByte(1.toByte())
            parcel.writeDouble(total!!)
        }
        parcel.writeString(fechaEmision)
    }

    companion object {

        @JvmField
        val CREATOR: Parcelable.Creator<Factura> = object : Parcelable.Creator<Factura> {
            override fun createFromParcel(`in`: Parcel): Factura {
                return Factura(`in`)
            }

            override fun newArray(size: Int): Array<Factura?> {
                return arrayOfNulls(size)
            }
        }
    }
}