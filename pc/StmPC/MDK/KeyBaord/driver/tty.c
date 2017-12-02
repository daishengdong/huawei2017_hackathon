#include "tty.h"
#include "../include/hw_config.h"
//#include "../init/stm32f10x_it.h"

#define  tty_pin_tx	GPIO_Pin_9
#define  tty_pin_rx GPIO_Pin_10

void tty_init(void){
		USART_InitTypeDef USART_InitStructure;
		GPIO_InitTypeDef GPIO_InitStructure;
		RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA|RCC_APB2Periph_USART1|RCC_APB2Periph_AFIO, ENABLE);
		//config pin
	  GPIO_InitStructure.GPIO_Pin = tty_pin_tx;	         //tx
		GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF_PP; 
		GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz; 
		GPIO_Init(GPIOA, &GPIO_InitStructure);		   

		GPIO_InitStructure.GPIO_Pin = tty_pin_rx;	         //rx
		GPIO_InitStructure.GPIO_Mode = GPIO_Mode_IN_FLOATING;  
		GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz; 
		GPIO_Init(GPIOA, &GPIO_InitStructure);
	
		//usart configure
	  USART_StructInit(&USART_InitStructure);
	  USART_InitStructure.USART_BaudRate =115200;
	  USART_InitStructure.USART_WordLength = USART_WordLength_8b;
	  USART_InitStructure.USART_StopBits = USART_StopBits_1;
	  USART_InitStructure.USART_Parity = USART_Parity_No;
	  USART_InitStructure.USART_HardwareFlowControl = USART_HardwareFlowControl_None;
	  USART_InitStructure.USART_Mode = USART_Mode_Rx | USART_Mode_Tx;	 
	  USART_Init(USART1,& USART_InitStructure);			  	  
	  USART_Cmd(USART1, ENABLE);
		/* Enable the USART Receive interrupt */
		USART_ITConfig(USART1, USART_IT_RXNE, ENABLE);
}
/*******************************************************************************
* Function Name  : USART1_IRQHandler
* Description    : This function handles USART1 global interrupt request.
* Input          : None
* Output         : None
* Return         : None
*******************************************************************************/
void USART1_IRQHandler(void)
{
	u8 rev;
	rev=USART_ReceiveData(USART1);
	tty_printf(&rev);
	//ReveiveCmd(rev);
}


int tty_command(u8 *cmd){
		return 1;
}

int tty_printf(u8 *str){
	while(*str){
		USART_SendData(USART1,*str++);
		while(USART_GetFlagStatus(USART1,USART_FLAG_TXE)==RESET);
	}
	return 1;
}
int tty_printf_H(char *mode,u8 *str){
	u8 tmp;
	while(*str){
		if(mode[0]=='%'&&mode[1]=='X'){
			tmp=*str;
			tmp=tmp>>4;
			if(tmp>=10){
				tmp=tmp-10+'A';
			}else{tmp+='0';}
			USART_SendData(USART1,tmp);
			while(USART_GetFlagStatus(USART1,USART_FLAG_TXE)==RESET);
			tmp=*str++;
			tmp=tmp&0x0f;
			if(tmp>=10){
				tmp=tmp-10+'A';
			}else{tmp+='0';}
			USART_SendData(USART1,tmp);
			while(USART_GetFlagStatus(USART1,USART_FLAG_TXE)==RESET);
		}else{
			USART_SendData(USART1,*str++);
			while(USART_GetFlagStatus(USART1,USART_FLAG_TXE)==RESET);
		}
	}
	return 1;
}
