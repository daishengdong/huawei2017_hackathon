#include "task.h"

void task1(void *pdata){
				u8 status=0,i;
				u8 rxbuf[5],txbuf[5];
				for(i=0;i<4;i++){
						txbuf[i]=i+'0';
				}
				rxbuf[4]=0x00;
				txbuf[4]=0x00;
				tty_init();
				NRF24L01_Init();
				tty_printf("this is 2.4G test \r\n");
				while(status==0){
					status=NRF24L01_Check();
					if(status)
							tty_printf("connect ok \r\n");				
					else
							tty_printf("connect failed \r\n");
					DelayMs(1000);
				}
				/********send data**********/
				tty_printf("slave part change to send mode\r\n");
				NRF_TX_Mode();
				DelayMs(10);
				/*********added by user*************/
				
				
				//for example
				/*
				do{
 						tty_printf("send Data:");
 						tty_printf(txbuf);
 						tty_printf("\r\n");
 						status = NRF_Tx_Dat(txbuf);
				}while(status==20||status==10);
				/****************************/	
}

