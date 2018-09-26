package com.freelance.ascstb.cobranza

import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.view.View
import android.widget.Toast

class LoginActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)
    }

    fun onLoginClick(view: View) {
        Toast.makeText(this, "Hi", Toast.LENGTH_SHORT).show()
    }
}
