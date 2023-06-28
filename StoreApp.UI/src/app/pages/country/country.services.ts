import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { environment } from './../../../environments/environment';

const baseUrl = `${environment.apiURL}/Country`;

@Injectable({
    providedIn: 'root'
})
export class CountryService {
    constructor(private http: HttpClient) { }

    // getCountryList(): Observable<any> {
    //     return this.http.get<any>(`${baseUrl}/GetCountryList`);
    // }
    getCountryList(filterDetail: any): Observable<any> {
        const httpOptions = {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        }
        return this.http.post<any>(`${baseUrl}/GetCountryList`, filterDetail, httpOptions);
    }
}