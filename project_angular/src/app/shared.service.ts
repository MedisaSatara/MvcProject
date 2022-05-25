import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as _ from 'lodash';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(public http:HttpClient) { }

  readonly url='https://localhost:44364/api/events';

  getAllEvent():Observable<any[]>{

    return this.http.get<any[]>(this.url+'/getallevents');
  }
  
  getEventsBySport(sport:string):Observable<any[]>{
    return this.http.get<any[]>(`${this.url}/GetEventsBySport/sport=${sport}`);
  }
  
  getEventsByCategory(category:string):Observable<any[]>{
    return this.http.get<any[]>(`${this.url}/GetEventsByCategory/category=${category}`);
  }
 
  getEventsByCompetition(competition:string):Observable<any[]>{
    return this.http.get<any[]>(`${this.url}/GetEventsByCompetition/competition=${competition}`);
  }

  getDropDownText(id: any,object: any)
  {
    const selObj=_.filter(object,function(o: { id: any; }){
      return(_.includes(id,o.id));
    });
    return selObj;
  }

}
