// graduate-trainee.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class GraduateTraineeService {
  private apiUrl = 'http://localhost:5038/api/GraduateTrainee';
  private baseUrlForDegree: string = 'http://localhost:5038/api/Degree';
  private baseUrlForTrainee: string = 'http://localhost:5038/api/GraduateTrainee';
  private apiUrlGetById ='http://localhost:5038/api/GraduateTrainee/GetById';

  constructor(private http: HttpClient) {}
  GetAllDegrees(): Observable<any> {
    return this.http.get(`${this.baseUrlForDegree}`);
  }
  createGraduateTrainee(data: any): Observable<any> {
    const createUrl = `${this.apiUrl}/Create`;
    return this.http.post(createUrl, data);
  }
  getTraineeDetailsById(id: number): Observable<any> {
    return this.http.get(`${this.baseUrlForTrainee}/GetById/${id}`)
  }
  updateTraineeDetails(id: number,  updateData: any): Observable<any> {
    return this.http.put(`${this.baseUrlForTrainee}/Update/${id}`, updateData, {});
  }
  getGraduateTraineeById(id: number): Observable<any> {
    const url = `${this.apiUrlGetById}/${id}`;
    return this.http.get(url);
  }
  GetAllDegreesID(): Observable<any> {
    return this.http.get(`${this.baseUrlForDegree}`);
  }
// graduate-trainee.service.ts

deleteGraduateTrainee(id: number): Observable<any> {
  return this.http.delete(`${this.baseUrlForTrainee}/Delete/${id}`);
}

}
