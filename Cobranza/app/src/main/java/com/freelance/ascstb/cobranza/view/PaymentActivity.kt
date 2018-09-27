package com.freelance.ascstb.cobranza.view

import android.app.Activity
import android.content.Intent
import android.graphics.Bitmap
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.provider.MediaStore
import android.util.Log
import android.view.View
import com.freelance.ascstb.cobranza.R

class PaymentActivity : AppCompatActivity() {

    val REQUEST_IMAGE_CAPTURE = 1

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_payment)

        Log.d(TAG, "onCreate: ")
    }

    fun onLoadPhotoClicked(view: View) {
        Log.d(TAG, "onLoadPhotoClicked: ")
        dispatchTakePictureIntent()

    }

    fun onContinueClicked(view: View) {
        Log.d(TAG, "onContinueClicked: ")
        //Implement Validations
    }

    private fun dispatchTakePictureIntent() {
        Log.d(TAG, "dispatchTakePictureIntent: ")
        Intent(MediaStore.ACTION_IMAGE_CAPTURE).also { takePictureIntent ->
            takePictureIntent.resolveActivity(packageManager)?.also {
                startActivityForResult(takePictureIntent, REQUEST_IMAGE_CAPTURE)
            }
        }
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        Log.d(TAG, "onActivityResult: ")
        if (requestCode == REQUEST_IMAGE_CAPTURE && resultCode == Activity.RESULT_OK) {
            Log.d(TAG, "onActivityResult: Picture received")
            val imageBitmap = data!!.extras.get("data") as Bitmap
        }
    }

    companion object {
        private val TAG = PaymentActivity::class.java.simpleName + "_TAG"
    }
}
