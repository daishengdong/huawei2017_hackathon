#include "usart.h"
#include "../init/stm32f10x_it.h"
#include "../includes/Head.h"
//#include "stm32f10x.h"

/*******************
*author:Zachary
*file:usart.c
********************/
#define  usart_pin_tx	GPIO_Pin_2
#define  usart_pin_rx GPIO_Pin_3
#define  Buffer_Size 20

//Receive Buffer
u8 Rev_Buffer[Buffer_Size];

/***********function*************/
void usart_init(void){
		USART_InitTypeDef USART_InitStructure;
		GPIO_InitTypeDef GPIO_InitStructure;

		//config pin
	  GPIO_InitStructure.GPIO_Pin = usart_pin_tx;	         //tx
		GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF_PP; 
		GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz; 
		GPIO_Init(GPIOA, &GPIO_InitStructure); 

		GPIO_InitStructure.GPIO_Pin = usart_pin_rx;	         //rx
		GPIO_InitStructure.GPIO_Mode = GPIO_Mode_IN_FLOATING;  
		GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz; 
		GPIO_Init(GPIOA, &GPIO_InitStructure);
	
		//usart configure
	  USART_StructInit(&USART_InitStructure);
	  USART_InitStructure.USART_BaudRate =19200;
	  USART_InitStructure.USART_WordLength = USART_WordLength_8b;
	  USART_InitStructure.USART_StopBits = USART_StopBits_1;
	  USART_InitStructure.USART_Parity = USART_Parity_No;
	  USART_InitStructure.USART_HardwareFlowControl = USART_HardwareFlowControl_None;
	  USART_InitStructure.USART_Mode = USART_Mode_Rx | USART_Mode_Tx;	 
	  USART_Init(USART2,& USART_InitStructure);
		//irq fun
		USART_ITConfig(USART2,USART_IT_RXNE,ENABLE);
		//open usart2
	  USART_Cmd(USART2, ENABLE);
}

void USART2_IRQHandler(void){
	static u8 i=0;
	u16 temp;
	static HeadForRecv Head;
	static CMD_PKG     cmd;
	if(USART_GetITStatus(USART2,USART_IT_RXNE)!=RESET){
		USART_ClearITPendingBit(USART2,USART_IT_RXNE);
		Rev_Buffer[i]=USART_ReceiveData(USART2);
	}
	if(USART_GetFlagStatus(USART2,USART_FLAG_ORE)==SET){
		USART_ClearFlag(USART2,USART_FLAG_ORE);
		USART_ReceiveData(USART2);
	}
	if(i==0){
			Head.magic1=Rev_Buffer[i];
			}
	else if(i==1){
			temp=Rev_Buffer[i];
			temp<<=8;
			Head.pkg_len=temp;
			}
	else if(i==2){
			Head.pkg_len+=Rev_Buffer[i];
	}
	else if(i==3){
			Head.magic2=Rev_Buffer[i];
			}
	else if(i==4){
			Head.content_type=Rev_Buffer[i];
			}
	else if(i==5){
			Head.reserve=Rev_Buffer[i];
	}
	else if(i==6){
			cmd.op_type=Rev_Buffer[i];
	}
	else if(i==7){
			cmd.dev_id=Rev_Buffer[i];
	}
	else{
			//cmd->
			if(Head.magic1!='Q'&&Head.magic2!='B')
			{
				switch (cmd.dev_id){
					case	ID_LAMB1:break;
					case	ID_LAMB2:break;
					case	ID_CDPLAYER:break;
					case ID_HEATER:break;
					case ID_INDICATOR:break;//连接指示灯:			
					default:return;
				}
			}			
		 i=0;
	}
	i++;
}

void usart_send(u8 *data){
	while(*data){
		USART_SendData(USART2,*data++);
		while(USART_GetFlagStatus(USART2,USART_FLAG_TXE)==RESET);
	}
}


