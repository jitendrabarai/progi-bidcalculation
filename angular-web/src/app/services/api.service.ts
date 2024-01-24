// used to call api service and get response from the server.
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, finalize, map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private router: Router,
  ) {}

  // Static method - this should probably be an instance method, not static
  static callApi(arg0: string, arg1: undefined[], arg2: string, arg3: boolean, arg4: boolean, arg5: boolean) {
    throw new Error('Method not implemented.');
  }

  // Generic API call method
  callApi(
    requestUrl: any,
    requestParams: any,
    requestType: any,
  ): any {

    // Determine the request type and call the corresponding method
    if (requestType == 'POST') {
      return this.callPOSTRequest(requestUrl, requestParams);
    }
  }




  // POST request method
  private callPOSTRequest(requestUrl: any, requestParams: any): Observable<any> {
    return this.http
      .post<any>(this.baseUrl + requestUrl, requestParams)
      .pipe(
        finalize((): void => {
        }),
        map((res: any): any => {
          return res;
        }),
        catchError(this.handleError('error', []))
      );
  }


  // Error handling method
  private handleError<T>(
    _operation = 'operation',
    _result?: T
  ): (error: any) => Observable<T> {
    return (error: any): Observable<T> => {
      if (error.status == 401) {
        localStorage.removeItem('accessToken');
        this.router.navigate(['/']);
      }
      return throwError(error);
    };
  }
}
