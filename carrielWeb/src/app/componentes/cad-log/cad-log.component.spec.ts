import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadLogComponent } from './cad-log.component';

describe('CadLogComponent', () => {
  let component: CadLogComponent;
  let fixture: ComponentFixture<CadLogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadLogComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
