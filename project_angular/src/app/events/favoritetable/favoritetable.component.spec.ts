import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoritetableComponent } from './favoritetable.component';

describe('FavoritetableComponent', () => {
  let component: FavoritetableComponent;
  let fixture: ComponentFixture<FavoritetableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavoritetableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavoritetableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
