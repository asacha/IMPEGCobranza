package com.freelance.ascstb.cobranza.model.data

import com.freelance.ascstb.cobranza.model.data.local.LocalDataSource

class DataRepository(private var remoteDataRepository: DataRepository, private var localDataSource: LocalDataSource) {

}