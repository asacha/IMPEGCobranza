package com.freelance.ascstb.cobranza.view

import android.app.Activity
import android.content.DialogInterface
import android.content.Intent
import android.graphics.Bitmap
import android.graphics.BitmapFactory
import android.os.Bundle
import android.provider.MediaStore
import android.support.v7.app.AppCompatActivity
import android.util.Log
import android.view.View
import android.widget.Toast
import com.freelance.ascstb.cobranza.R
import com.freelance.ascstb.cobranza.utils.Dialog


class PaymentActivity : AppCompatActivity() {
    private lateinit var image: Bitmap
    private val REQUEST_IMAGE_CAPTURE = 1
    private val PICK_IMAGE = 2

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_payment)

        Log.d(TAG, "onCreate: ")
    }

    fun onLoadPhotoClicked(view: View) {
        Log.d(TAG, "onLoadPhotoClicked: ")

        Dialog.createDecision(this, "Cargar evidencia", "Selecciona el origen",
                "Tomar Foto", { dialogInterface: DialogInterface, value: Int -> onCameraClicked() },
                "Galería", { dialogInterface, value -> onGalleryClicked() })
    }

    private fun onCameraClicked() {
        Log.d(TAG, "onCameraClicked: ")
        dispatchTakePictureIntent()
    }

    private fun onGalleryClicked() {
        Log.d(TAG, "onGalleryClicked: ")

        val intent = Intent()
        intent.type = "image/*"
        intent.action = Intent.ACTION_GET_CONTENT
        startActivityForResult(Intent.createChooser(intent, "Select Picture"), PICK_IMAGE)
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
            Log.d(TAG, "onActivityResult: Picture taken and received")
            image = data!!.extras.get("data") as Bitmap
            Toast.makeText(this, "Imagen cargada", Toast.LENGTH_SHORT).show()
        } else if (requestCode == PICK_IMAGE  && resultCode == Activity.RESULT_OK) {
            Log.d(TAG, "onActivityResult: Picture picked")

            image = BitmapFactory.decodeStream(contentResolver.openInputStream(data!!.data))

            Toast.makeText(this, "Imagen cargada", Toast.LENGTH_SHORT).show()
        } else {
            super.onActivityResult(requestCode, resultCode, data)
        }
    }

    companion object {
        private val TAG = PaymentActivity::class.java.simpleName + "_TAG"
    }
}
