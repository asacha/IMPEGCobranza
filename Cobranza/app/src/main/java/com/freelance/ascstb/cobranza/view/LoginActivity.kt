package com.freelance.ascstb.cobranza.view

import android.content.Intent
import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.view.View
import android.widget.Toast
import com.freelance.ascstb.cobranza.R

class LoginActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)
    }

    fun onLoginClick(view: View) {
        val intent = Intent(applicationContext, InvoiceActivity::class.java)
        intent.putExtra("TOKEN", "1234")

        startActivity(intent)
    }
}
