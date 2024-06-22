import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DegreeServiceService {

  // http://localhost:5038/api/Degree
  // private baseUrl = 'http://localhost:5279/api/Degree';

  // constructor(private http: HttpClient) {}

  // getAllDegree(): Observable<any> {
  //   //const url = `${this.baseUrl}/allemployees`;
  //   return this.http.get(this.baseUrl);
  //   //return this.http.get(`${this.apiUrl}/${id}`);
  // }

  private apiUrl = 'http://localhost:5038/api/GraduateTrainee/GetAll';

  // Inject the HttpClient module in the constructor
  constructor(private http: HttpClient) { }

  // Function to make the API call and return the data as an Observable
  getAllData(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }


}
