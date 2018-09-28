package com.freelance.ascstb.cobranza.utils

import android.app.AlertDialog
import android.content.Context
import android.content.DialogInterface
import android.os.Build
import android.util.Log

object Dialog {
    fun createDecision(context: Context, title: String, message: String, btn1Text: String, btn1Listener: (DialogInterface, Int) -> Unit, btn2Text: String, btn2Listener: (DialogInterface, Int) -> Unit) {
        Log.d(TAG, "createDecision: ")
        lateinit var builder: AlertDialog.Builder

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            builder = AlertDialog.Builder(context, android.R.style.Theme_Material_Dialog_Alert)
        } else {
            builder = AlertDialog.Builder(context)
        }

        builder
                .setTitle(title)
                .setMessage(message)
                .setPositiveButton(btn1Text, btn1Listener)
                .setNegativeButton(btn2Text, btn2Listener)
                .setIcon(android.R.drawable.ic_dialog_info)
                .show()
    }

    private val TAG = Dialog::class.java.simpleName + "_TAG"
}