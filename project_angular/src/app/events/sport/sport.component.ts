import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { EventsComponent } from '../events.component';

@Component({
  selector: 'app-sport',
  templateUrl: './sport.component.html',
  styleUrls: ['./sport.component.css']
})
export class SportComponent implements OnInit {

  selectedSportName: string='';
  @Output()
  onSportNameSelected: EventEmitter<string> = new EventEmitter();
  constructor(public service:SharedService) { }
  
  SportList: any=[];
  sport='';

  mySelect='';
  ngOnInit(): void {
  }

  setSportName(event:any)
  {
    this.onSportNameSelected.emit(event);
  }

}
