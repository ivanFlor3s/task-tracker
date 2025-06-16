import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemTaskCardComponent } from './item-task-card.component';

describe('ItemTaskCardComponent', () => {
  let component: ItemTaskCardComponent;
  let fixture: ComponentFixture<ItemTaskCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItemTaskCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItemTaskCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
