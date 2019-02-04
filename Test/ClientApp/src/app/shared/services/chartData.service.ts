import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import {ChartSeries} from '../models/chartSeries';

@Injectable()
export class ChartService {

  protected basePath = 'https://localhost:44385';

    constructor(protected httpClient: HttpClient) {

    }

    public getData(): Observable<ChartSeries> {
        return this.httpClient.get<ChartSeries>(`${this.basePath}/api/chartdatavalues`);
    }
}
