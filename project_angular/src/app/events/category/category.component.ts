import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  selectedCategoryName: string='';
  @Output()
  onCategoryNameSelected: EventEmitter<string> = new EventEmitter();
  constructor(public service:SharedService) { }
  
  CategoryList: any=[];
  ngOnInit(): void {
  }

  setCategoryName(event:any)
  {
    this.onCategoryNameSelected.emit(event);
  }

}
