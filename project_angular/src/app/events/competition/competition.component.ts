import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-competition',
  templateUrl: './competition.component.html',
  styleUrls: ['./competition.component.css']
})
export class CompetitionComponent implements OnInit {

  selectedCompetitionName: string='';
  @Output()
  onCompetitionNameSelected: EventEmitter<string> = new EventEmitter();
  constructor(public service:SharedService) { }
  
  CompetitionList: any=[];
  ngOnInit(): void {

  }

  setCompetitionName(event:any)
  {
    this.onCompetitionNameSelected.emit(event);
  }

}
