package com.freelance.ascstb.cobranza.view

import android.arch.lifecycle.Observer
import android.arch.lifecycle.ViewModelProviders
import android.content.Intent
import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.util.Log
import android.view.View
import android.widget.EditText
import com.freelance.ascstb.cobranza.R
import com.freelance.ascstb.cobranza.utils.Keys
import com.freelance.ascstb.cobranza.viewmodel.LoginViewModel

class LoginActivity : AppCompatActivity() {
    private lateinit var clientNumber: String
    private lateinit var viewModel: LoginViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)

        Log.d(TAG, "onCreate: ")
        this.viewModel = ViewModelProviders.of(this).get(LoginViewModel::class.java)

        viewModel.login.observe(this, Observer { loginResponse ->
            Log.d(TAG, "login.observe: $loginResponse")

            if (loginResponse!!.token != null && loginResponse.token!!.isNotEmpty()) {
                val intent = Intent(applicationContext, InvoiceActivity::class.java)
                intent.putExtra(Keys.TOKEN, loginResponse.token)
                intent.putExtra(Keys.CLIENT_NUMBER, clientNumber)

                startActivity(intent)
            }
        })
    }

    fun onLoginClick(view: View) {
        Log.d(TAG, "onLoginClick: ")
        clientNumber = findViewById<EditText>(R.id.etClientNum).text.toString()
        viewModel.setClientNumber(clientNumber)
        viewModel.setPassword(findViewById<EditText>(R.id.etPassword).text.toString())

        viewModel.login
    }

    companion object {
        private val TAG = LoginActivity::class.java.simpleName + "_TAG"
    }
}
